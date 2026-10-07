# 🃏 Memory Card Game (C# Windows Forms)

A dynamic, interactive, and responsive desktop **Memory Card Game** built with **C#** and **.NET Framework (Windows Forms)**. The game supports both **Single-Player** and **Two-Player (VS)** modes, custom player avatars, sound settings, customizable timer controls, and multiple difficulty levels.

---

## 📸 Screenshots

| Main Menu | Gameplay Board |
| :---: | :---: |
| <img width="1100" height="663" alt="image" src="https://github.com/user-attachments/assets/7f9a63ff-9c47-49d2-817f-568d8e51afa3" />
 | <img width="1125" height="664" alt="image" src="https://github.com/user-attachments/assets/0526f27b-7c14-42f5-84b5-cbbd2087481f" />

---

## ✨ Features

- 🎮 **Multiple Game Modes:**
  - **Single Player:** Play against the clock and try to match all cards before time runs out.
  - **Two Players (1v1):** Pass-and-play turn-based competition with real-time score tracking.

- ⚙️ **Customizable Settings:**
  - **3 Difficulty Levels:**
    - **Easy:** 6 Cards (3 Pairs)
    - **Medium:** 12 Cards (6 Pairs)
    - **Hard:** 24 Cards (12 Pairs)
  - Customizable round durations and total round counts.

- 👤 **Player Customization:**
  - Dynamic avatar choice (Boys/Girls presets) with visual selection feedback (image darkening effect).
  - Custom player names with input validation (`ErrorProvider`).

- ⚡ **Asynchronous & Non-Blocking UI:**
  - Built using `async / await` and `Task.Delay` to handle card flipping animations smoothly without freezing the UI or blocking the main thread.
  - State management (`isProcessing`) to prevent double-clicking or race conditions during card matching.

- 🎨 **Modern UI Components:**
  - Custom UI controls like `RoundedPictureBox` and `ModernButton`.
  - Dynamic button hover states (`MouseEnter` / `MouseLeave`).

---

## 🛠️ Tech Stack & Concepts Applied

- **Language:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Asynchronous Programming:** `async`, `await`, `Task.Delay`
- **Object-Oriented Design (OOP):** Structs/Classes for game state management (`stGameInfo`, `stRoundInfo`).
- **Graphics & UI:** Custom `ColorMatrix` for dimming unselected avatars, dynamic control generation, and custom event handlers.
- **Data Structures:** `HashSet<T>` for random pair distribution and `List<T>` shuffling algorithms.

---

## 👥 Collaborative Development & Version Control

This project was built collaboratively by a team of two developers using **Git** and **GitHub** for version control and smooth collaboration.

### 🔄 Collaborative Workflow Applied:
- **Feature Branching:** Developed new controls, game logic, and UI elements in separate feature branches to keep the codebase clean.
- **Push & Pull Synchronization:** Frequently synchronized progress via `git push` and `git pull` to integrate changes safely.
- **Merge & Conflict Resolution:** Executed clean merges into the `main` branch, resolving code conflicts using Visual Studio Merge Tools.


## 👥 Authors & Contributors

- **Karim Ghanem (me)** - [GitHub Profile](https://github.com/KARIM9k)
- **Co-Developer Ahmad Malak** - [GitHub Profile](https://github.com/Ahamd3511)

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2019 or later (with **.NET Desktop Development** workload installed).
- .NET Framework 4.7.2 or higher.

### Installation & Running

1. **Clone the repository:**
  git clone [https://github.com/KARIM9k/MemoryGame1.git](https://github.com/KARIM9k/MemoryGame1.git)

## 📸 GamePlay Video
https://github.com/user-attachments/assets/796f7d12-fb12-4241-af87-cb37e9379e7d

