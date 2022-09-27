class StopWatch{
    private bool _isRunning;
    private DateTime _startTime;
    private TimeSpan _timer;

    public StopWatch(){
        _isRunning = false;
        Console.WriteLine("Stopwatch Initialized ...");
    }

    public void Start(){
        if(_isRunning){
            throw new InvalidOperationException("Stopwatch is already running");
            return;
        }
        _isRunning = true;
        _startTime = DateTime.Now;
    }
    public void End(){
        if(!_isRunning){
            throw new InvalidOperationException("Stopwatch is already Off");
            return;
        }

        _isRunning = false;
        _timer = DateTime.Now - _startTime;
        Console.WriteLine($"Duration is  {_timer.Minutes}");

    }

    ~StopWatch(){
        Console.WriteLine("Stopwatch is destroyed");
    }
}