# UnityDisableUIIssue
Showcasing that disabling and enabling UI doesnt work in newer Editor versions

## In Editor version 2021.3.2
The UI is enabled and disabled as expected, the reenabled UI acts as it did before

## In Editor version 2021.3.7 (at least) and up
The UI works before being disabled, once it is enabled again, EventSystem is oblivious of its existence, no user interaction is registered, but the UI is visible.
