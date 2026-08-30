# EventEase - Blazor Front-End Project

## Overview
EventEase is a comprehensive Blazor WebAssembly application created to demonstrate core and advanced Blazor concepts, including component architecture, data binding, form validation, routing, and centralized state management.

## Features Implemented
- **Event Card Component**: Reusable component utilizing two-way data binding (`@bind`) and `EventCallback` to notify parent components.
- **Routing & Navigation**: Clean page navigation with `@page` directives and `NavigationManager`.
- **Validation**: Strict validation using `EditForm`, `DataAnnotationsValidator`, and custom error messages.
- **State Management & Attendance Tracker**: Scoped `AppState` service to coordinate user session info and attendance numbers across unrelated components.

## Copilot Assistance Summary
- **Step 1 - Scaffolding Components**: Copilot generated initial Razor templates and model classes with appropriate DataAnnotations.
- **Step 2 - Event Handling & Binding**: Copilot suggested two-way binding patterns (`@bind:event="oninput"`) and typed `EventCallback<T>` signatures.
- **Step 3 - Form Validation & Routing**: Copilot assisted in resolving validation messages and creating scoped state listeners.
- **Step 4 - Optimization**: Refactored rendering cycles and standardized modular components for performance.
