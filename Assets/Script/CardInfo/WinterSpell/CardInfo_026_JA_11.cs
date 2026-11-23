using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_026_JA_11 : CardInfo
{
    public CardInfo_026_JA_11()
    {
        this.cardNo = "026_JA_11";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "トゥイード夫人";
        this.cardName2 = "心優しい未亡人";
        this.power = 2;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.VanessaMorales;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
