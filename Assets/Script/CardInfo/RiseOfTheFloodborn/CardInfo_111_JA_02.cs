using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_02 : CardInfo
{
    public CardInfo_111_JA_02()
    {
        this.cardNo = "111_JA_02";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "トレメイン夫人";
        this.cardName2 = "高圧的な家長";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Samanta Erdini";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = true; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = true; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
