using EmpCore.Infrastructure.MessageBus;

namespace BlogPostManagementService.Contracts;

public class BlogPostDeletedEvent : IntegrationEvent
{
    public const string EventName = "BlogPostManagement.BlogPostDeleted";
    public Guid BlogPostId { get; }
    public string AuthorId { get; }

    public BlogPostDeletedEvent(Guid blogPostId, string authorId, DateTime createdAt) : base (EventName, createdAt)
    {
        BlogPostId = blogPostId;
        AuthorId = authorId;
    }        
}