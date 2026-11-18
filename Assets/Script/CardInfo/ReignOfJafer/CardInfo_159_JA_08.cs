using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_159_JA_08 : CardInfo
{
    public CardInfo_159_JA_08()
    {
        this.cardNo = "159_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ゴー・ゴー・トマゴ";
        this.cardName2 = "機械技師";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JenniferWu;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
