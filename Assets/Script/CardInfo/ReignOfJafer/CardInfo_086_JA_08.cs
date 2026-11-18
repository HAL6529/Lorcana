using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_08 : CardInfo
{
    public CardInfo_086_JA_08()
    {
        this.cardNo = "086_JA_08";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "バジル";
        this.cardName2 = "覆面捜査官";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
