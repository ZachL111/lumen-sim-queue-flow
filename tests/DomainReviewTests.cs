using LumenSimQueueFlow;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(67, 31, 11, 83);
        if (DomainReviewLens.Score(item) != 215) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
