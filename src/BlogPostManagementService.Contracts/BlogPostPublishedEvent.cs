using EmpCore.Infrastructure.MessageBus;

namespace BlogPostManagementService.Contracts;

public class BlogPostPublishedEvent : IntegrationEvent
{
    public const string EventName = "BlogPostManagement.BlogPostPublished";
        
    public Guid BlogPostId { get; }
    public string AuthorId { get; }
    public DateTime PublishDateTime { get; }
    public string FeedbackEmailAddress { get; }

    public BlogPostPublishedEvent(
        Guid blogPostId,
        string authorId,
        DateTime publishDateTime,
        string feedbackEmailAddress,
        DateTime createdAt) : base(EventName, createdAt)
    {
        BlogPostId = blogPostId;
        AuthorId = authorId;
        PublishDateTime = publishDateTime;
        FeedbackEmailAddress = feedbackEmailAddress;
    }
}