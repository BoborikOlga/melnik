using Models_03.Interfaces;
using System;
using System.Collections.Generic;

namespace Models_03.Models
{
    public class QueuingSystem : IQueuingSystem
    {
        private const int outputChannelLimit = 1;
        private const int inputChannelLimit = 1;
        private const int queueLimit = 1;

        private double _p;
        private double _pi1;
        private double _pi2;
        private int _count;

        private List<Request> _inputChannel;
        private Queue<Request> _queue;
        private List<Request> _outputChannel;

        private int _totalTimeInSystem = 0;
        private int _processedRequests = 0;
        private int _totalRequests = 0;

        private Random _randomGenerator;

        public QueuingSystem(IDictionary<string, double> parameters)
        {
            _p = parameters["p"];
            _pi1 = parameters["Pi1"];
            _pi2 = parameters["Pi2"];
            _count = Convert.ToInt32(parameters["count"]);

            _randomGenerator = new Random((int)DateTime.Now.Ticks);
            _inputChannel = new List<Request>();
            _queue = new Queue<Request>();
            _outputChannel = new List<Request>();
        }


        public IDictionary<string, double> Imitate()
        {
            var result = new Dictionary<string, double>();
            for (int i = 0; i < _count; i++)
            {
                DoTick();
            }
            result["A"] = _processedRequests / (double)_count;
            result["Wc"] = _totalTimeInSystem / (double)_totalRequests;
            result["Lc"] = _totalRequests / (double)_count;

            return result;
        }


        private void DoTick()
        {
            ProccessOutputChannel();
            ProccessQueue();
            ProccessInputChannel();
            ProccessSource();
        }

        private void ProccessOutputChannel()
        {
            if (_outputChannel.Count == 0)
            {
                return;
            }
            var outputProbability = _randomGenerator.NextDouble();
            if (outputProbability > _pi2)
            {
                var request = _outputChannel[_outputChannel.Count - 1];
                _outputChannel.Remove(request);
                request.IncTime();
                _totalTimeInSystem += request.TimeInSystem;
                _processedRequests++;
            }
        }

        private void ProccessQueue()
        {
            if (_queue.Count == 0)
            {
                return;
            }
            if (_outputChannel.Count < outputChannelLimit)
            {
                var request = _queue.Dequeue();
                request.IncTime();
                _outputChannel.Add(request);
            }
        }

        private void ProccessInputChannel()
        {
            if (_inputChannel.Count == 0)
            {
                return;
            }
            var inputChannelProcessProbability = _randomGenerator.NextDouble();
            if (inputChannelProcessProbability > _pi1)
            {
                var request = _inputChannel[_inputChannel.Count - 1];
                request.IncTime();
                _inputChannel.Remove(request);
                if (_queue.Count < queueLimit)
                {
                    _queue.Enqueue(request);
                }
            }
        }

        private void ProccessSource()
        {
            var sourceProbability = _randomGenerator.NextDouble();
            if (sourceProbability > _p)
            {
                if (_inputChannel.Count >= inputChannelLimit)
                {
                    return;
                }
                _inputChannel.Add(new Request());
                _inputChannel[_inputChannel.Count - 1].IncTime();
                _totalRequests++;
            }
        }
    }
}
