using CCSANoteApp.Domain;

namespace NoteApp.DTOs
{
    public class NoteDto
    {
        public User NoteCreator { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public GroupName Group { get; set; }
    }
}
