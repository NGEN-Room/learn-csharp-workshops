# Project – Inventory Reference Tracker

## 🧠 Goal:
Understand how reference types behave when objects are shared or updated through an inventory system.

---

## 🔧 Instructions:
1. Create a class `Item` with:
   - `Name`, `Quantity`

2. Create a class `Inventory` with:
   - `List<Item>` field
   - Method `AddItem(Item item)`
   - Method `ShowInventory()` that loops through and prints all items

3. In `Main`, do the following:
   - Create an `Item` object
   - Add it to multiple inventories
   - Modify the item’s quantity in one inventory
   - Observe the change in both (because of reference sharing)

---

## 🧪 Example Output:
```
Inventory A:
- Potion x2

Inventory B:
- Potion x2
```

---

## ✅ Bonus Challenges:
- Clone item before adding (to prevent shared reference)
- Add a method to deep copy an inventory
- Show difference between value type and reference type behavior

---

## 🛠 How To Start

Create a new console app:
```bash
dotnet new console -o InventoryTracker
cd InventoryTracker
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
