using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_11 : CardInfo
{
    public CardInfo_181_JA_11()
    {
        this.cardNo = "181_JA_11";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "マクホーン";
        this.cardName2 = "サイコーにクールな警官";
        this.power = 6;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PatriBalanovsky;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
