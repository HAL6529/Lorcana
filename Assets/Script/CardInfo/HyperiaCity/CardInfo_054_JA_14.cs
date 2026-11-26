using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_054_JA_14 : CardInfo
{
    public CardInfo_054_JA_14()
    {
        this.cardNo = "054_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ダンテ";
        this.cardName2 = "忠実なアレブリヘ";
        this.power = 6;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MelissaBallesterosAndAlejandroHernandez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
