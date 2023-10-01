import { redirect } from "react-router-dom";
import { deleteTask } from "../tasks";

export async function action({ params }) {
    //throw new Error("oh dang!");
    await deleteTask(params.taskId);
    return redirect("/");
}