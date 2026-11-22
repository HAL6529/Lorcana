using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_10 : CardInfo
{
    public CardInfo_014_JA_10()
    {
        this.cardNo = "014_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フラッシュ";
        this.cardName2 = "記録の専門家";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SergioMancinell;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
