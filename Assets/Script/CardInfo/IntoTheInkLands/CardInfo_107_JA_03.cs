using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_107_JA_03 : CardInfo
{
    public CardInfo_107_JA_03()
    {
        this.cardNo = "107_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヘイヘイ";
        this.cardName2 = "いつのまにか探検家";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Jiahui Eva Gao";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = true; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = true; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
