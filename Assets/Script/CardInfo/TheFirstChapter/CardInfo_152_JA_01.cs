using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_152_JA_01 : CardInfo
{
    public CardInfo_152_JA_01()
    {
        this.cardNo = "152_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "モーリス";
        this.cardName2 = "世界的な発明家";
        this.power = 2;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = "Alex Accorsi";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = true; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
