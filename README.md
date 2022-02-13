# LocalNetworkChecker ローカルネットワークチェッカー

## キャプチャ画像
![Main screen capture image](./img/main_screen.png "Main screen capture image")

## 概要

- 自PCが属しているネットワークの周辺にあるホストに対し、PINGを送信して反応を調べます。
  - PING応答があれば、ARP情報を基にMACアドレスも調べます。
  - IgNetMap や NetEnum のようなアプリがほしくて作りました。
    - IgNetMap
      - https://forest.watch.impress.co.jp/article/2006/01/24/ignetmap.html
    - NetEnum5
      - https://forest.watch.impress.co.jp/library/software/netenum/

## 動作

- 起動するとキャプチャ画像のような画面が表示されます。
  - 「このPCのアドレス」という文言の右横には選択リストが表示されます。
    - このアプリを実行しているPCに存在するネットワークインタフェースと、それに対応するIPアドレスが選択肢として並びます。
    - ただし、ループバックインタフェースや起動していないインタフェースは除外されます。
  - 「チェック対象アドレス」の欄には、選択リストで選択したIPアドレスの第4オクテットが「*」になったものが表示されます。
  - 「実行」ボタンをクリックすると、「チェック対象アドレス」の「*」を1から255の値にしたIPアドレスに対し、PINGを送信し、結果をグリッドに表示します。
    - 「変更」ボタンをクリックすると、1から255以外にも変更できます。
      - タイムアウト時間もデフォルトの3秒から変更できます。

## 参考にしたもの

- ネットワークインターフェス情報の取得
  - C# でローカル IP アドレスを取得する | Delft スタック
    - https://www.delftstack.com/ja/howto/csharp/get-local-ip-address-in-csharp/
- PING送信
  - Ping クラス (System.Net.NetworkInformation) | Microsoft Docs
    - https://docs.microsoft.com/ja-jp/dotnet/api/system.net.networkinformation.ping?view=net-6.0
  - Pingを送信する - .NET Tips (VB.NET,C#...)
    - https://dobon.net/vb/dotnet/internet/ping.html
- ARP情報の取得
  - [C#] ARP要求を送信してリモートPCのMACアドレスを取得する（SendARP関数） – 偏差値40プログラマー
    - https://hensa40.cutegirl.jp/archives/6689

## 備考

- ライセンスはMITにしました。
  - ご利用はご自由にどうぞ…
