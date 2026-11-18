using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_106_JA_08 : CardInfo
{
    public CardInfo_106_JA_08()
    {
        this.cardNo = "106_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヒロ・ハマダ";
        this.cardName2 = "直感的発想家";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
