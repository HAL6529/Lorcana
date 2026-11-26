using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_119_JA_14 : CardInfo
{
    public CardInfo_119_JA_14()
    {
        this.cardNo = "119_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ペピータ";
        this.cardName2 = "イメルダの右腕";
        this.power = 4;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.VanessaMorales;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>{ EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
