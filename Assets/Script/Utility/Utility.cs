using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Utility
{
    public static void Shuffle<T>(this IList<T> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = UnityEngine.Random.Range(0, i + 1);
            var tmp = list[i];
            list[i] = list[j];
            list[j] = tmp;
        }
    }

    public static Define.CHARA_NAME RandomEnemyName()
    {
        return Define.CHARA_NAME.MASHROOM;
    }

    public static Define.ITEM_NAME RandomItemName()
    {
        return Define.ITEM_NAME.APPLE;
    }
}

public static class Calculator
{
    public static int CalculatePower(int atk, float mag)
    {
        return (int)(atk * mag);
    }

    public static int CalculateDamage(int power, int def)
    {
        int damage = power - def;
        if (damage < 1)
        {
            damage = 1;
        }
        return damage;
    }

    public static int CalculateRemainingHp(int hp, int damage)
    {
        int remainingHp = hp - damage;
        if (remainingHp < 0)
        {
            remainingHp = 0;
        }
        return remainingHp;
    }

    public static bool JudgeHit(float dex, float eva)
    {
        if(UnityEngine.Random.Range(1,101) >= dex * 100)
        {
            return false;
        }
        if(UnityEngine.Random.Range(1, 101) <= eva * 100)
        {
            return false;
        }
        return true;
    }
}

public static class Coroutine
{
    public static IEnumerator DelayCoroutine(float seconds, System.Action action)
    {
        yield return new WaitForSeconds(seconds);
        action?.Invoke();
    }
}