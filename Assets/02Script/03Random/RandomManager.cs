using System.Collections;
using UnityEngine;

public class RandomManager : MonoBehaviour
{
    public enum eRandomType
    {
        None,

        value,
        nextDouble,
        range,
        next,
    }

    [SerializeField] private eRandomType randomType;
    [SerializeField] private int count = 10;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);

        int _count = count;

        var _rnd = new System.Random();

        var _stopWatch = new System.Diagnostics.Stopwatch();
        _stopWatch.Start();

        for (var i = 0; i < _count; i++)
        {
            switch (randomType)
            {
                case eRandomType.value:
                    float _r1 = Random.value;               // 0.0~1.0 사이의 임의의 부동 소수점을 반환
                    break;

                case eRandomType.nextDouble:
                    float _r2 = (float)_rnd.NextDouble();   // double 타입의 임의의 수를 반환하는 메서드 (0.0~1.0 사이의 double 타입 수를 랜덤 반환)
                    break;

                case eRandomType.range:
                    float _r3 = Random.Range(0, count);     // 유니티 내장 함수로 int인 경우 min이상~max미만, float인 경우 min이상~max이하
                    break;

                case eRandomType.next:
                    // float _r4 = _rnd.Next();             // 임의의 정수를 반환하는 메서드 (음수는 나오지 않음)
                    // float _r4 = _rnd.Next(count);        // max보다 작은 임의의 정수를 반환하는 메소드 (음수는 나오지 않음)
                    float _r4 = _rnd.Next(0, count);        // min이상~max미만의 임의의 랜덤한 수를 반환하는 메서드
                    break;
            }
        }

        _stopWatch.Stop();
        Debug.LogFormat("Timer({0}) : {1} ms", randomType.ToString(), _stopWatch.ElapsedMilliseconds);
        _stopWatch.Reset();
    }

}

/*
속도 : Next() - nextDouble() - value() - Range(min, max) 순서
그런데 Next() 괄호 내에 min, max가 들어가는 순간, NextDouble()과 순서가 바뀐다.
*/