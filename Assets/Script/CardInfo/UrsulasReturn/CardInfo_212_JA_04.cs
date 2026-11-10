using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_212_JA_04 : CardInfo
{
    public CardInfo_212_JA_04()
    {
        this.cardNo = "212_JA_04";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ÉWÉÉÉXÉ~Éì";
        this.cardName2 = "çªîôÇÃèóêÌém";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.noc4urne;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
