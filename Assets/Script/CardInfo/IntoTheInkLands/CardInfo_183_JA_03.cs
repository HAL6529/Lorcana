using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_183_JA_03 : CardInfo
{
    public CardInfo_183_JA_03()
    {
        this.cardNo = "183_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "ファンキーな洞窟探検家";
        this.power = 0;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Grace Tran";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = true; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
