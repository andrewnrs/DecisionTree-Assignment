using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace PageService.Pages
{
    [Table("Pages")]
    public class Page : AuditedEntity<Guid>
    {
        private Page(string title, string slug, string content, bool isHomePage)
        {
            Title = title;
            Slug = slug;
            Content = content;
            IsHomePage = isHomePage;
        }

        public static Page From(PageVo pageVo)
        {
            return new(pageVo.Title, pageVo.Slug, pageVo.Content, pageVo.IsHomePage);
        }

        [StringLength(60)]
        public string Title { get; set; }

        [StringLength(60)]
        public string Slug { get; set; }

        [StringLength(1000)]
        public string Content { get; set; }

        public bool IsHomePage { get; set; } = false;
    }
}
