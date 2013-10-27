Lemon2 - Functional Http Handler
================================

HTTP で XML をやり取りするような簡単な WebAPI を構築するとしましょう。
ASP.NET や WCF はどうでしょうか？
複雑な Web.config や、使いづらい HttpRequest や型安全でない UriTemplate はいつでも私たちを悩ませます。
Lemon2 はこのようなコンテキストに対して最適なソリューションです。

特徴
----
このライブラリを使うことで下記のようなメリットが得られます。

* シンプルな Web.config
* 関数による [Server](https://github.com/otf/lemon/blob/master/samples/LemonSample.Code/Server.fs "Server.fs") の定義
* HTTP Request に対してのパターンマッチ
* コンビネータによる簡単な HTTP Response の生成

オリジナル
----------
Lemon2 は、[Lemon](https://github.com/otf/lemon) から派生したプロジェクトです。
オリジナルのプロジェクトは、個人的な問題により、今後メンテナンスされることはないでしょう。
そこで、フォークして別プロジェクトとして再始動させました。

もしオリジナルの Lemon プロジェクトがメンテナンスされる時が来たら、
このプロジェクトは終了し、このプロジェクトの作業は Lemon プロジェクトに取り込んでもらうようにします。
そのため、大幅な変更は行いません。
