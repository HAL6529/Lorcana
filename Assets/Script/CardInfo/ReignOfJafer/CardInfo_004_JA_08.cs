using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_08 : CardInfo
{
    public CardInfo_004_JA_08()
    {
        this.cardNo = "004_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "画期的コック";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarlosLuzzi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
