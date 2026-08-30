@using EventEase.Models

<div class="card mb-3 p-3 shadow-sm border rounded">
    <h4>@Event.Title</h4>
    <p class="text-muted">Location: @Event.Location | Date: @Event.Date.ToShortDateString()</p>
    
    <div class="d-flex align-items-center gap-2 mb-2">
        <label class="form-label mb-0">Edit Title (Two-Way Binding):</label>
        <input type="text" class="form-control w-50" @bind="Event.Title" @bind:event="oninput" />
    </div>

    <div class="d-flex align-items-center gap-2">
        <span>Attendees: <strong>@Event.AttendeesCount</strong></span>
        <button class="btn btn-sm btn-outline-primary" @onclick="IncrementCount">+ Add Attendee</button>
    </div>
</div>

@code {
    [Parameter]
    public EventItem Event { get; set; } = new();

    [Parameter]
    public EventCallback<EventItem> OnAttendeeAdded { get; set; }

    private async Task IncrementCount()
    {
        Event.AttendeesCount++;
        await OnAttendeeAdded.InvokeAsync(Event);
    }
}
