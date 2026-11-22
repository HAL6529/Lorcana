using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_10 : CardInfo
{
    public CardInfo_179_JA_10()
    {
        this.cardNo = "179_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "バジル";
        this.cardName2 = "粘り強いネズミ";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Detective};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
