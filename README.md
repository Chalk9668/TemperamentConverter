# 改弦更張（仮） - TemperamentConverter

## 日本語

改弦更張といいます。名前は中国の故事に基づいています。UTAUでノートをtフラグを使って所定の調律に書き換えるプラグインです（仮）。ワイがモアサプ民なのでMoreSamplerを想定してください。他にも対応したい。精度はサンプラーによりけり（モアサプは1cent単位）。

自由に変位は可能。一応12EDOに戻せたり。

更新する時？ワイが必要になったときだ。Vocalsifterで調教するよりはUTAU上でやったほうがラクだろうし、時間対効果とワイの微分音音楽技能と相談。

### やりたいこと（優先度順）

- 様々な不等分律なども使えたい
- .scl/.kbm や .tun 等の調律ファイルや調律情報をつかえるようにしたい
- おリッチなUIに

### 機能

現在利用可能な機能:

- 任意のEDOへの変換
- ユーザー定義スケール
- Relative Step機能（トランスポーズのようなもの）
- 12EDOへリセット

実装予定の機能:

- 純正律対応
- ミーントーン対応
- ランダムスケール生成
- リッチUI
- 简体中文
- 繁體中文
- 한국어
- Deutsch

### 注意:

- これは正式リリースではありません
- エラーや書き換え失敗が起こる可能性があります
-  これであなたの.ustファイルやシステムがぶち壊れようと、私は責任を負いません
-  開発者の微分音音楽技能、ならびに知識は正直言って微妙です

## English

This is TemperamentConverter. You can modify UTAU microtonally with the `t` flag. It can be used with Moresampler. I'm a Moresampler user.

### Features

Currently available features:

- Convert tuning to any EDO
- User-defined scales
- Relative step shifting (similar to transpose)
- Reset tuning to 12EDO

Planned features:

- Just Intonation support
- Meantone temperament support
- Random scale generation
- Rich UI
- 简体中文
- 繁體中文
- 한국어
- Deutsch

### WARNING

- This is not a full release version.
- It may cause errors, such as destroying UST files.
- I will not be held responsible.
- My microtonal techniques and knowledge are so-so.



History:2026-04-06
