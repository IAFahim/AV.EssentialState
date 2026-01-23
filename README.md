# AV.EssentialState

![Header](documentation_header.svg)

[![Unity](https://img.shields.io/badge/Unity-2022.3%2B-000000.svg?style=flat-square&logo=unity)](https://unity.com)
[![License](https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square)](LICENSE.md)

State management system for tracking object locations and operations using lightweight ID objects.

## ✨ Features

- **LocationState**: ScriptableObject-based ID for tracking where an object is (e.g., "InInventory", "OnGround").
- **OperationState**: ID for tracking what an object is doing (e.g., "Idle", "Crafting").
- **Identity System**: Implements `IUID` for integration with `BovineLabs.Core`.

## 📦 Installation

Install via Unity Package Manager (git URL).

### Dependencies
- **BovineLabs.Core**: Required for ObjectManagement.

## 🚀 Usage

1. Create `LocationState` assets via `Create > AV > EssentialState > LocationState`.
2. Assign them to components to track state.

```csharp
public class Item : MonoBehaviour
{
    public LocationState CurrentLocation;
}
```

## ⚠️ Status

- 🧪 **Tests**: Missing.
- 📘 **Samples**: None.
