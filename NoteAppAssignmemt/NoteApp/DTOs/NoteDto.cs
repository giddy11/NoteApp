﻿using CCSANoteApp.Domain;

namespace NoteApp.DTOs
{
    public class NoteDto
    {
        public virtual User NoteCreator { get; set; }
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        public virtual GroupName Group { get; set; }
    }
}
