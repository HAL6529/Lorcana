using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_102_JA_07 : CardInfo
{
    public CardInfo_102_JA_07()
    {
        this.cardNo = "102_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒpƒ`ƒƒ";
        this.cardName2 = "—·‚Ì“¹˜A‚ê";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LucaPinelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
