using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_143_JA_11 : CardInfo
{
    public CardInfo_143_JA_11()
    {
        this.cardNo = "143_JA_11";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ホンカー・マドルフット";
        this.cardName2 = "弱気な天才";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KamilMurzyn;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
