using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_224_JA_14 : CardInfo
{
    public CardInfo_224_JA_14()
    {
        this.cardNo = "224_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミゲル・リヴェラ";
        this.cardName2 = "街角の音楽家";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OmarLozano;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
