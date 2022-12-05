using UnityEngine;
using UnityEngine.UI;
using System;
using UniRx;
using UniRx.Triggers;

public static class ButtonExtensions
{
	public const float SameClickIntervalSecond = 0.5f;
	public const float OtherClickIntervalSecond = 0.1f;

	static float muteExpireTime;

	private static DateTime onClickTime;
	private static Vector2 clickPoint;
	private static Vector2 dragPoint;
	private const int thresholdMilisecond = 250;
	private const float thresholdPosition = 50.0f;

	public static bool Muted
	{
		get { return Time.realtimeSinceStartup < muteExpireTime; }
	}

	public static void OnOneClick(this Button button, Action callback)
	{
		if (button == null)
		{
			return;
		}

		button
			.OnPushAsObservable()
			.Where(_ => !Muted)
			.ThrottleFirst(TimeSpan.FromSeconds(SameClickIntervalSecond))
			.Subscribe(_ => {
				MuteASecond(OtherClickIntervalSecond);

				if (callback != null)
				{
					callback();
				}
			});
	}


	public static IObservable<float> OnPushAsObservable(this Button button)
	{
		var pressTimeObservable = Observable.ZipLatest(
			button.OnPointerDownAsObservable().Select(_ => Time.realtimeSinceStartup),
			button.OnPointerUpAsObservable().Select(_ => Time.realtimeSinceStartup),
			(t1, t2) => t2 - t1);

		return Observable.ZipLatest(
			pressTimeObservable,
			button.OnClickAsObservable(),
			(t, _) => t);
	}

	public static void MuteASecond(float muteTime)
	{
		muteExpireTime = Time.realtimeSinceStartup + muteTime;
	}
}