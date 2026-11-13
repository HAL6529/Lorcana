using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_093_JA_07 : CardInfo
{
    public CardInfo_093_JA_07()
    {
        this.cardNo = "093_JA_07";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ƒoƒWƒ‹";
        this.cardName2 = "”é‚©‚È“à’ÊŽÒ";
        this.power = 3;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
