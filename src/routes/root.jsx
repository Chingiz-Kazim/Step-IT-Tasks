import { Outlet, NavLink, Link, useLoaderData, Form, redirect, useNavigation, useSubmit } from "react-router-dom";
import { getTasks, createTask } from "../tasks";
import { useEffect, useState } from "react";

export async function action() {
    const task = await createTask();
    return redirect(`/tasks/${task.id}/edit`);
}

export async function loader({ request }) {
    const url = new URL(request.url);
    const q = url.searchParams.get("q");
    const tasks = await getTasks(q);
    return { tasks, q };
}
function Root() {
    const { tasks, q } = useLoaderData();
    const navigation = useNavigation();
    const submit = useSubmit();

    const [currentFilter, setCurrentFilter] = useState("all");


    const searching =
        navigation.location &&
        new URLSearchParams(navigation.location.search).has(
            "q"
        );

    useEffect(() => {
        document.getElementById("q").value = q;
    }, [q]);

    const handleFilterChange = (filter) => {
        setCurrentFilter(filter);
    }

        const filteredTasks = tasks.filter((task) => {
            if (currentFilter === "all") {
                return true;
            } else if (currentFilter === "favorite") {
                return task.favorite;
            } else if (currentFilter === "reminded") {
                return !task.favorite;
            }
        });
        return (
            <>
                <div id="sidebar">
                    <h1>React Router Tasks</h1>
                    <div>
                        <Form id="search-form" role="search">
                            <input
                                id="q"
                                className={searching ? "loading" : ""}
                                aria-label="Search tasks"
                                placeholder="Search"
                                type="search"
                                name="q"
                                defaultValue={q}
                                onChange={(event) => {
                                    const isFirstSearch = q == null;
                                    submit(event.currentTarget.form, {
                                        replace: !isFirstSearch,
                                    });
                                }}
                            />
                            <div
                                id="search-spinner"
                                aria-hidden
                                hidden={!searching}
                            />
                            <div
                                className="sr-only"
                                aria-live="polite"
                            ></div>
                        </Form>
                        <Form method="post">
                            <button type="submit">New</button>
                        </Form>

                    </div>
                    <Form method="post">
                        <div className="show">
                            <button type="button" onClick={() => handleFilterChange("all")}
            className={currentFilter === "all" ? "active" : ""}>All</button>
                            <button type="button" onClick={() => handleFilterChange("favorite")}
            className={currentFilter === "favorite" ? "active" : ""}>Done</button>
                            <button type="button" onClick={() => handleFilterChange("reminded")}
            className={currentFilter === "reminded" ? "active" : ""}>Reminded</button>
                        </div>
                    </Form>
                    <nav>
                        {tasks.length ? (
                            <ul>
                                {filteredTasks.map((task) => (
                                    <li key={task.id}>
                                        <NavLink
                                            to={`tasks/${task.id}`}
                                            className={({ isActive, isPending }) =>
                                                isActive
                                                    ? "active"
                                                    : isPending
                                                        ? "pending"
                                                        : ""
                                            }
                                        >
                                            <Link to={`tasks/${task.id}`}>
                                                {task.task ? (
                                                    <>
                                                        {task.task}
                                                    </>
                                                ) : (
                                                    <i>No Name</i>
                                                )}{" "}
                                                {task.favorite && <span>☑</span>}
                                            </Link>
                                        </NavLink>
                                    </li>
                                ))}
                            </ul>
                        ) : (
                            <p>
                                <i>No tasks</i>
                            </p>
                        )}
                    </nav>
                </div>
                <div id="detail"
                    className={
                        navigation.state === "loading" ? "loading" : ""
                    }>
                    <Outlet />
                </div>
            </>
        );
    }

export default Root;

