import './Paragraph.css';

function Paragraph({text,children}) {
  return (
    <p>
      {children}{text}
    </p>
  );
}

export default Paragraph;