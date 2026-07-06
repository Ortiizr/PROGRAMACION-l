import { useState } from "react";
import "./App.css";

function App() {
  // Variables de estado para cada campo
  const [nombre, setNombre] = useState("");
  const [correo, setCorreo] = useState("");
  const [contrasena, setContrasena] = useState("");
  const [mensaje, setMensaje] = useState("");

  // Expresión regular para validar el correo
  const formatoCorreo = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

  // Validaciones
  const nombreValido = nombre.trim().length >= 3;
  const correoValido = formatoCorreo.test(correo);
  const contrasenaValida =
    contrasena.length >= 6 && /\d/.test(contrasena);

  // El formulario es válido cuando todos los campos son correctos
  const formularioValido =
    nombreValido && correoValido && contrasenaValida;

  const manejarEnvio = (evento) => {
    evento.preventDefault();

    if (!formularioValido) {
      return;
    }

    setMensaje(`Formulario enviado correctamente. Bienvenido, ${nombre}.`);

    // Limpiar los campos
    setNombre("");
    setCorreo("");
    setContrasena("");
  };

  return (
    <div className="contenedor">
      <form className="formulario" onSubmit={manejarEnvio}>
        <h1>Formulario de registro</h1>

        <div className="grupo">
          <label htmlFor="nombre">Nombre</label>

          <input
            id="nombre"
            type="text"
            placeholder="Escribe tu nombre"
            value={nombre}
            onChange={(evento) => {
              setNombre(evento.target.value);
              setMensaje("");
            }}
          />

          {nombre.length > 0 && !nombreValido && (
            <p className="error">
              El nombre debe tener al menos 3 caracteres.
            </p>
          )}
        </div>

        <div className="grupo">
          <label htmlFor="correo">Correo electrónico</label>

          <input
            id="correo"
            type="email"
            placeholder="ejemplo@correo.com"
            value={correo}
            onChange={(evento) => {
              setCorreo(evento.target.value);
              setMensaje("");
            }}
          />

          {correo.length > 0 && !correoValido && (
            <p className="error">
              Introduce un correo electrónico válido.
            </p>
          )}
        </div>

        <div className="grupo">
          <label htmlFor="contrasena">Contraseña</label>

          <input
            id="contrasena"
            type="password"
            placeholder="Escribe tu contraseña"
            value={contrasena}
            onChange={(evento) => {
              setContrasena(evento.target.value);
              setMensaje("");
            }}
          />

          {contrasena.length > 0 && !contrasenaValida && (
            <p className="error">
              La contraseña debe tener al menos 6 caracteres y un número.
            </p>
          )}
        </div>

        <button type="submit" disabled={!formularioValido}>
          Enviar formulario
        </button>

        {mensaje && <p className="exito">{mensaje}</p>}
      </form>
    </div>
  );
}

export default App;