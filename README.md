# Mictlan Level 2 Game 🌋🦝

## Descripción 📄
**Mictlan Level 2 Game** es un juego de habilidad y supervivencia desarrollado en Unity. El jugador debe iniciar la misión acercándose a un NPC Mapache, atravesar un pasillo de montañas que chocan entre sí y evitar ser aplastado mientras avanza hacia la meta antes de que el tiempo se agote.

### Dinámica del Juego
Al acercarse al Mapache, se activa la misión y comienza una cuenta regresiva. Las montañas chocan y se cierran en intervalos, por lo que el jugador debe calcular el momento exacto para cruzar.

Durante el recorrido, aparecen **NPC Garzas** que otorgan **Turbo y Escudo temporal**, ayudando al jugador a correr más rápido y resistir el impacto por un breve momento.

> **Ayudas y Obstáculos:**
> * 🦢 **Garzas Guardianas:** Si te acercas a una, te otorga Turbo y un Escudo temporal.
> * 🗻 **Montañas en Colisión:** Se cierran constantemente y pueden aplastar al jugador.
> * ⏳ **Tiempo Límite:** Debes llegar al final antes de que el contador llegue a cero.

⚠️ **Game Over:** Si el jugador es aplastado o se acaba el tiempo, aparece la pantalla de derrota y se reinicia todo el nivel.

## Características Principales ✨
* 🗻 **Corredor de montañas** con peligro dinámico (colisiones).
* 🦝 **NPC Mapache** para iniciar la misión.
* 🦢 **Power-ups** de Turbo y Escudo otorgados por NPC Garzas.
* ⏱️ **Temporizador** que limita el tiempo para completar el desafío.
* 💥 **Sistema de detección de aplastamiento** que causa Game Over.
* 🔄 **Reinicio automático** de la misión al fallar.

## Controles 🎮

| Teclas | Acción |
| :---: | :--- |
| `W` `A` `S` `D` | Movimiento del jugador |

## Cómo Jugar 🕹️
1.  **Inicio:** Acércate al Mapache para activar la misión.
2.  **Objetivo:** Corre hacia el pasillo de montañas.
3.  **Estrategia:**
    * Calcula el momento exacto para cruzar antes de que las montañas choquen.
    * Acércate a las **Garzas** para obtener Turbo y Escudo, son vitales para pasar rápido.
4.  **Supervivencia:** Evita ser aplastado; de lo contrario aparecerá Game Over.
5.  **Tiempo:** Llega a la meta antes de que el tiempo llegue a 0.
6.  **Victoria:** Al llegar a la meta se completa la misión con éxito.

## Tecnologías Utilizadas 🛠️
* **Engine:** Unity
* **Lenguaje:** C# (Scripts de gameplay, lógica de colisión, NPCs y UI)
* **Componentes:** Sistema de físicas, animaciones y UI de Unity.

## Estructura del Proyecto 📂
* `Scripts/` – Lógica del jugador, misión, Mapache, Garzas, temporizador, colisiones y Game Over.
* `Prefabs/` – Personajes NPC, montañas, triggers, efectos y power-ups.
* `Scenes/` – Escena principal del nivel del Mictlán.
* `UI/` – Pantalla de inicio, temporizador, indicador de turbo/escudo y Game Over.

## Requisitos 🛠️
* Unity 2021 o superior.
* S.O.: Windows, macOS o Linux.

## Cómo ejecutar el proyecto 🚀

1.  Clonar el repositorio:
    ```bash
    git clone https://github.com/AngelicaGuerOl/Mictlan-level-2-game.git
    ```
2.  Abrir **Unity Hub**.
3.  Dar clic en **Add** y seleccionar la carpeta del proyecto clonado.
4.  Abrir la escena principal dentro de `Scenes/`.
5.  Presionar el botón **Play**.

---

## 📹 Video demostrativo
Puedes ver cómo funciona el juego en el siguiente enlace:

👉 [Watch video on Google Drive](https://drive.google.com/file/d/1XpCEjJGPT-O9OCY4Mm3j2pdocBCaKMex/view?usp=drive_link)


---

## Autor ✒️
**Developed by:** Angélica Guerrero Olvera
