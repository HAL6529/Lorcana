using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_06 : CardInfo
{
    public CardInfo_153_JA_06()
    {
        this.cardNo = "153_JA_06";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "タダシ・ハマダ";
        this.cardName2 = "ベイマックスの発明者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JeannePlounevez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
