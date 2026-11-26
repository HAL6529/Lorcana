using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_010_JA_14 : CardInfo
{
    public CardInfo_010_JA_14()
    {
        this.cardNo = "010_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミゲル・リヴェラ";
        this.cardName2 = "有望な音楽家";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JuanPabloVelazquez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
