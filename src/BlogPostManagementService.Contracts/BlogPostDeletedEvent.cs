using EmpCore.Infrastructure.MessageBus;

namespace BlogPostManagementService.Contracts;

public class BlogPostDeletedEvent : IntegrationEvent
{
    public const string EventName = "BlogPostManagement.BlogPostDeleted";
    public Guid BlogPostId { get; }
    public string AuthorId { get; }

    public BlogPostDeletedEvent(
        Guid blogPostId,
        string authorId,
        DateTime raisedAt,
        string eventName = EventName) : base (EventName, raisedAt)
    {
        BlogPostId = blogPostId;
        AuthorId = authorId;
    }        
}