using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_180_JA_10 : CardInfo
{
    public CardInfo_180_JA_10()
    {
        this.cardNo = "180_JA_10";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ハドソン";
        this.cardName2 = "熱心な読書家";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Gargoyle };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
