using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_011_JA_11 : CardInfo
{
    public CardInfo_011_JA_11()
    {
        this.cardNo = "011_JA_11";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "パウアタン首長";
        this.cardName2 = "堅守の指導者";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KierstenHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
