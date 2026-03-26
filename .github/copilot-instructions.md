# Copilot Instructions

## Project Guidelines
- For this project, use architecture where `RepositoryManagerBase<T>` receives `DataManager` via constructor, and `ItemManager`/`StorageLocationManager` persist changes after `Add`, `Delete`, and `Update` using private `SaveToFile()` methods.

## Testing Guidelines
- Keep tests consolidated in a single file rather than splitting into multiple test files/projects at this stage.