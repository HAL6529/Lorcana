using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_009_JA_06 : CardInfo
{
    public CardInfo_009_JA_06()
    {
        this.cardNo = "009_JA_06";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉiÉîÉBÅ[Éìâ§éq";
        this.cardName2 = "ópêSê[Ç¢àÍìôçqäCém";
        this.power = 2;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FrancescoColucci;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
