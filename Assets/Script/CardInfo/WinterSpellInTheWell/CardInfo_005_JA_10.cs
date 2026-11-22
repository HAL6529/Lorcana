using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_10 : CardInfo
{
    public CardInfo_005_JA_10()
    {
        this.cardNo = "005_JA_10";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ヒギンス";
        this.cardName2 = "潜入捜査官";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NargesJafari;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
