using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_037_JA_10 : CardInfo
{
    public CardInfo_037_JA_10()
    {
        this.cardNo = "037_JA_10";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "グウィセイント";
        this.cardName2 = "獰猛な狩り手";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JoaoMoura;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
