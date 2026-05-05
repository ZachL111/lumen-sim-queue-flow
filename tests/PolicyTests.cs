using LumenSimQueueFlow;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(74, 76, 23, 12, 13);
        if (Policy.Score(signalcase_1) != 156) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(63, 102, 12, 18, 11);
        if (Policy.Score(signalcase_2) != 154) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(79, 80, 9, 22, 12);
        if (Policy.Score(signalcase_3) != 156) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
