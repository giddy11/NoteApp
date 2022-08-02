using CCSANoteApp.Domain;
using FluentNHibernate.Mapping;

namespace CCSANoteApp.DB.Mappings
{
    public class NoteMap : ClassMap<Note>
    {
        public NoteMap()
        {
            Table("Notes");
            Id(note => note.Id);
            Map(note => note.NoteCreator);
            Map(note => note.Title);
            Map(note => note.Content);
            Map(note => note.Group);
            Map(note => note.CreatedDate);
            Map(note => note.UpdatedDate);
        }
    }
}
