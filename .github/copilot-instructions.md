# Copilot Instructions

## Project Guidelines
- For this project, use architecture where `RepositoryManagerBase<T>` receives `DataManager` via constructor, and `ItemManager`/`StorageLocationManager` persist changes after `Add`, `Delete`, and `Update` using private `SaveToFile()` methods.