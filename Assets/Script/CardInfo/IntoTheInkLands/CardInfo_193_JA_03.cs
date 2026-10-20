using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_193_JA_03 : CardInfo
{
    public CardInfo_193_JA_03()
    {
        this.cardNo = "193_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "シンバ";
        this.cardName2 = "唯一の王";
        this.power = 4;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = "Mariana Moreno";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = true; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
