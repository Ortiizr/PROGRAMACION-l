import { useState } from "react";
import "./App.css";

function App() {
  const [comentario, setComentario] = useState("");
  const [categoria, setCategoria] = useState("");
  const [satisfaccion, setSatisfaccion] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();

    alert(
      `Comentario: ${comentario}\nCategoría: ${categoria}\nSatisfacción: ${satisfaccion}`
    );
  };

  return (
    <div className="container">
      <h1>Formulario de Opinión</h1>

      <form onSubmit={handleSubmit}>
        <div className="campo">
          <label>Escribe tu comentario:</label>
          <textarea
            value={comentario}
            onChange={(e) => setComentario(e.target.value)}
            placeholder="Escribe tu opinión aquí..."
          ></textarea>
        </div>

        <div className="campo">
          <label>Selecciona una categoría:</label>
          <select
            value={categoria}
            onChange={(e) => setCategoria(e.target.value)}
          >
            <option value="">Selecciona una opción</option>
            <option value="Servicio">Servicio</option>
            <option value="Producto">Producto</option>
            <option value="Soporte">Soporte</option>
          </select>
        </div>

        <div className="campo">
          <label>Nivel de satisfacción:</label>

          <div className="radio-group">
            <label>
              <input
                type="radio"
                name="satisfaccion"
                value="Buena"
                checked={satisfaccion === "Buena"}
                onChange={(e) => setSatisfaccion(e.target.value)}
              />
              Buena
            </label>

            <label>
              <input
                type="radio"
                name="satisfaccion"
                value="Regular"
                checked={satisfaccion === "Regular"}
                onChange={(e) => setSatisfaccion(e.target.value)}
              />
              Regular
            </label>

            <label>
              <input
                type="radio"
                name="satisfaccion"
                value="Mala"
                checked={satisfaccion === "Mala"}
                onChange={(e) => setSatisfaccion(e.target.value)}
              />
              Mala
            </label>
          </div>
        </div>

        <button type="submit">Enviar</button>
      </form>

      <div className="resultado">
        <h2>Datos ingresados</h2>
        <p><strong>Comentario:</strong> {comentario}</p>
        <p><strong>Categoría:</strong> {categoria}</p>
        <p><strong>Satisfacción:</strong> {satisfaccion}</p>
      </div>
    </div>
  );
}

export default App;