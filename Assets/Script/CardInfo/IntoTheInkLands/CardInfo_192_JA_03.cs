using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_03 : CardInfo
{
    public CardInfo_192_JA_03()
    {
        this.cardNo = "192_JA_03";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "シンバ";
        this.cardName2 = "戦う王子";
        this.power = 5;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = "Andrea Femerstrand";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = true; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = true; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
