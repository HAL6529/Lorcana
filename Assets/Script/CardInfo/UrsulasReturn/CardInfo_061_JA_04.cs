using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_04 : CardInfo
{
    public CardInfo_061_JA_04()
    {
        this.cardNo = "061_JA_04";
        this.inkCost = 10;
        this.availableInk = false;
        this.cardName1 = "Second Star to the Right";
        this.cardName2 = "右から2番目の星";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.NataliaTrykowska;
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether10 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
