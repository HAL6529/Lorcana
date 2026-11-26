using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_117_JA_14 : CardInfo
{
    public CardInfo_117_JA_14()
    {
        this.cardNo = "117_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ヘクター・リヴェラ";
        this.cardName2 = "街角の音楽家";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer2 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
