using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_10 : CardInfo
{
    public CardInfo_146_JA_10()
    {
        this.cardNo = "146_JA_10";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ジーニー";
        this.cardName2 = "魔人探偵";
        this.power = 4;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
